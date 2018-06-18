(function registrationResultCtrlInit() {
    'use strict';

    function registrationResultCtrl($state) {
        var self = this;

        self.successMessage = 'Success!';
        self.errorMessage = 'Oops';

        function reloadForm() {
            $state.go('register');
        }

        self.cancel = function () {
            reloadForm();
        }
    }

    angular.module('app').controller('RegistrationResultCtrl', ['$state', registrationResultCtrl]);
}());