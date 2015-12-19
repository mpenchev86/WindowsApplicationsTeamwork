var express = require('express');

require('./server/config/express');
require('./server/config/mongoose');
require('./server/config/passport');
require('./server/config/routes');

var app = express();
var port = 1234;

app.listen(port);
console.log("Server running on port: " + port);