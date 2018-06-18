(function appRoutingConfigInit() {
    'use strict';

    function routingConfig($stateProvider, $urlRouterProvider) {

        $stateProvider
            .state('register',
                {
                    url: '/register',
                    templateUrl: 'app/registration/edit/registrationEditTemplate.html',
                    controller: 'RegistrationsEditCtrl',
                    controllerAs: 'vm'
                })
            .state('result',
                {
                    url: '/register/result',
                    templateUrl: 'app/registration/result/registrationResultTemplate.html',
                    controller: 'RegistrationResultCtrl',
                    controllerAs: 'vm'
                });
    }

    angular.module('app').config(['$stateProvider', '$urlRouterProvider', routingConfig]);
}());