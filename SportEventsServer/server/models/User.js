/**
 * Created by Reni on 18/12/2015.
 */

var mongoose = require('mongoose');
              //require ('crypto')

var userSchema = mongoose.Schema({
    username: String,
    firstName: String,
    lastName: String
    //salt: String,
    //hashPass: String
});


//userSchema.method({
//    authenticate: function(password) {
//        if (encryption.generateHashedPassword(this.salt, password) === this.hashPass) {
//            return true;
//        }
//        else {
//            return false;
//        }
//    }
//});

var User = mongoose.model('User', userSchema);

module.exports.seedInitialUsers = function() {
    User.find({}).exec(function (err, collection) {
        if (err) {
            console.log('Cannot find users: ' + err);
            return;
        }

        if (collection.length === 0) {
            //var salt;
            //var hashedPwd;
            //
            //salt = encryption.generateSalt();
            //hashedPwd = encryption.generateHashedPassword(salt, 'Ivaylo');
            User.create({
                username: 'reni.getskova',
                firstName: 'reni',
                lastName: 'getskova'
                //salt: salt,
                //hashPass: hashedPwd,
            });
            console.log('Users added to database...');
        }
    });
};