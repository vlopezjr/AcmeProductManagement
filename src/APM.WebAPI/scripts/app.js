(function () {
    'use strict';

    angular.module('inventoryApp', [
        // Angular modules 
        'ngRoute',

        // Custom modules 
        "inventoryService",
        "productService"

        // 3rd Party Modules

    ])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'index.html'
            })
            .when('/list', {
                templateUrl: 'productListView.html'
            })
            .when('/edit', {
                templateUrl: 'productEditView.html'
            })
            .otherwise({
                redirectTo: '/list'
            });
    }]);
})();