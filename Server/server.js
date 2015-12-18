/**
 * Created by Reni on 18/12/2015.
 */
var express = require('express'), //NODE_ENV || development
    bodyParser = require('body-parser'),  //bodyparser??
    mongoose = require('mongoose'),
    passport = require('passport'),
    LocalPassport = require('passport-local'),
    cookieParser = require('cookie-parser'),
    session = require('express-session'),
    crypto = require('crypto');

var port = 1234;

var app = express();
app.use(cookieParser());
app.use(bodyParser.json());
app.use(session({secret: 'magic unicorns'}));

app.use(passport.initialize());
//app.use(function(req, res, next){
//    console.log(req.user);
//    next();
//});

mongoose.connect('mongodb://localhost/sportsevents');
var db = mongoose.connection;
db.once('open', function(err){
    if (err) {
        console.log("Database could not be open: " + err);
        return;
    }

    console.log('Database up and running');
});

db.on('error', function(err){
    console.log("Database error: " + err);
    return;
});

var userSchema = mongoose.Schema({
    username: String,
    firstName: String,
    lastName: String,
    salt: String,
    hashPass: String
});

userSchema.method({
    authenticate: function (password) {
        if (generateHashPassword(this.salt, password) === this.hashPass) {
            return true;
        }
        else {
            return false;
        }
    }
});

var User = mongoose.model('User', userSchema);
User.find({}).exec(function(err, collection){
    if (err) {
        console.log('Can not find user: ' + err);
        return;
    }

    if (collection.length === 0) {
        var salt = generateHashPassword();
        var hashPassword = generateHashPassword(salt, 'qwerty');
        User.create({username:'reni.getskova', firstName: 'reni', lastName: 'getskova', salt: salt, hashPass: hashPassword});
        console.log('Users added to database...');
    }
});

passport.use(new LocalPassport(function(username, password, done){
    User.findOne({username: username}).exec(function(err, user){
        if (err) {
            console.log('Error loading user: ' + err);
            return;
        }

        if (user) {
            return done(null, user);
        }
        else {
            return done(null, false);
        }
    })
}));

passport.serializeUser(function(user, done){
    if (user) {
        return done(null. user._id);
    }

});

passport.deserializeUser(function(user, done){
   User.findOne({_id: id}).exec(function(err, user){
       if (user) {
           return done(null, user);
       }
       else {
           return done(null, false);
       }
   })
});

app.post('/login', function(req, res, next){
   var auth = passport.authenticate('local', function(err, user){
       if (err) {
           return next(err);
       }
       if (!user) {
           res.send({success: false});
       }
       req.logIn(user, function(err){
           if (err) {
               console.log('Login failed: ' + err);
               return next(err);
           }
           res.send({success: true, user: user});
       })
   });

   auth(req, res, next);
});

app.post('/logout', function(req, res, next){
    req.logout();
    res.end();
});

app.get('/home', function(req, res){
   res.send('her');
});

app.listen(port);
console.log("Server running on port " + port);

