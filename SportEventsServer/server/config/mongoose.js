/**
 * Created by Reni on 18/12/2015.
 */

var mongoose = require('mongoose'),
    user = require('../models/User');

module.exports = function() {
    mongoose.connect('mongodb://localhost/sportsevents');
    var db = mongoose.connection;

    db.once('open', function (err) {
        if (err) {
            console.log('Database could not be opened: ' + err);
            return;
        }

        console.log('Database up and running...')
    });

    db.on('error', function (err) {
        console.log('Database error: ' + err);
    });

    user.seedInitialUsers();
};