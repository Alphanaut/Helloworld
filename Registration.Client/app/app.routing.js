(function appRoutingConfigInit() {
    'use strict';

    function routingConfig($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/register');
        $stateProvider
            .state('register', {
                    url: '/register',
                    templateUrl: 'app/registration/edit/registrationEditTemplate.html',
                    controller: 'RegistrationEditCtrl',
                    controllerAs: 'vm'
            })
            .state('result', {
                    url: '/register/result',
                    templateUrl: 'app/registration/result/registrationResultTemplate.html',
                    controller: 'RegistrationResultCtrl',
                    controllerAs: 'vm'
            })
            .state('adminListing', {
                    url: '/admin/listing',
                    templateUrl: 'app/admin/registration/list/adminRegistrationListTemplate.html',
                    controller: 'AdminRegistrationListCtrl',
                    controllerAs: 'vm'
            });
    }

    angular.module('app').config(['$stateProvider', '$urlRouterProvider', routingConfig]);
}());