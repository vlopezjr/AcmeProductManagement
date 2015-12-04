(function () {
    'use strict';

    angular
        .module('inventoryApp')
        .controller('productController', productController);

    productController.$inject = ['$scope', 'Products']; 

    function productController($scope, Products) {
        

        $scope.products = Products.query();        
    }
})();
