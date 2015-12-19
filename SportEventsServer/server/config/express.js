/**
 * Created by Reni on 18/12/2015.
 */

var express = require('express'),
    bodyParser = require('body-parser');
    //cookieParser = require('cookie-parser'),
    //session = require('express-session'),
    //passport = require('passport');

module.exports = function(app) {
    //app.use(cookieParser());
    app.use(express('/'));
    app.use(bodyParser.json());
    //app.use(session({secret: 'magic unicorns'}));

    //app.use(passport.initialize());
    //app.use(passport.session());
};