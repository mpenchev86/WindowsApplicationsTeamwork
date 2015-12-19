/**
 * Created by Reni on 19/12/2015.
 */

var express = require('express'),
    bodyParser = require('body-parser');

var app = express();
app.use(bodyParser.json());

var sports = [];
var events = [];

app.get('/api/sports', function(req, res){
   res.json({
      result: sports
   });
});

app.get('/api/events', function(req, res){
    res.json({
        result: events
    });
});

app.post('/api/events', function(req, res) {
    var event = req.body;
    event.id = events.length + 1;
    events.push(event);

    res.status(201).json({result: event});
});

var port = 3000;
app.listen(port);
console.log("Server running on port " + port);