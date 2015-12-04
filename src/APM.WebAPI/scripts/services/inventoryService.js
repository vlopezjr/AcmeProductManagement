(function () {
    'use strict';

    var inventoryService = angular.module('inventoryService', ['ngResource']);

    inventoryService.factory('Items', ['$resource', function ($resource) {

        return $resource('/api/items/', {}, {
            query: { method: 'GET', params: {}, isArray: true}
        });

    }]);
})();