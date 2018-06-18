(function appSettingsInit(global) {
    'use strict';

    var registrationapp = global.registrationapp || {},
        constants = {};

    registrationapp.apiPath = registrationapp.apiPath || '';  // here we could set default values 
    registrationapp.webAppPath = registrationapp.webAppPath || '';

    constants = {
        serverPath: registrationapp.apiPath,
        webAppPath: registrationapp.webAppPath
    };

    angular.module('app').constant('appSettings', constants);
}(this));