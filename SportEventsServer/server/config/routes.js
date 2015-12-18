/**
 * Created by Reni on 18/12/2015.
 */

var controllers = require('../controllers');

module.exports = function(app) {
    app.get('/api/users', controllers.users.getAllUsers);
    app.post('/api/users', controllers.users.createUser);
};
