(function registrationResultCtrlInit() {
    'use strict';

    function registrationResultCtrl() {
        var self = this;

        self.successMessage = 'Success!';
        self.errorMessage = 'Oops';
    }

    angular.module('app').controller('RegistrationResultCtrl', [registrationResultCtrl]);
}());