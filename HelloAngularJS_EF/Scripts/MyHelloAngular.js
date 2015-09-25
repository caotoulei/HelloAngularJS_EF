var MyHelloAngular = angular.module('MyHelloAngular', ['ngRoute']).config(function ($locationProvider) {
    $locationProvider.html5Mode(true);
});

MyHelloAngular.controller('HomeController', HomeController);

MyHelloAngular.controller('LoginController', LoginController);

MyHelloAngular.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);

var configFunction = function ($routeProvider, $httpProvider) {
    $routeProvider.
        when('/routeOne', {
            templateUrl: '/routesDemo/one'
        })
        .when('/routeTwo/:donuts', {
            templateUrl: function (params) { return '/routesDemo/two?donuts=' + params.donuts; }
        })
        .when('/routeThree', {
            templateUrl: '/routesDemo/three'
        })
        .when('/login', {
             templateUrl: 'Account/Login',
             controller: LoginController
         })
        .otherwise({
            redirectTo: '/Home/Playground'
        });

    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');

}

configFunction.$inject = ['$routeProvider', '$httpProvider'];

MyHelloAngular.config(configFunction);