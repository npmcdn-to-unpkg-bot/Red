/* jslint node: true */

'use strict';

var apickli = require('apickli');

module.exports = function() {
  this.Before(function(scenario, callback) {
    this.apickli = new apickli.Apickli('http', process.env.HOSTNAME);
    this.apickli.setHeaders([{name: 'Content-Type', value: 'application/json'}]);
    callback();
  });
};
