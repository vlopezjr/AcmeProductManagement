(function () {
    'use strict';

    var productService = angular.module('productService', ['ngResource']);

    productService.factory('Products', ['$resource', function ($resource) {

        return $resource('/api/products/:id', {}, {
            query: { method: 'GET', params: {}, isArray: true }
        });

    }]);
})();