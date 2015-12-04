(function () {
    'use strict';

    angular
        .module('inventoryApp')
        .controller('inventoryController', inventoryController);

    inventoryController.$inject = ['$scope', 'Items']; 

    function inventoryController($scope, Items) {
        $scope.items = Items.query();
    }
})();
