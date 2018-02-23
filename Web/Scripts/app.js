var app = angular.module('App', []);
var baseAddress = 'http://localhost:13662/api/Dashboard/';
var url = "";

app.factory('Factory', function ($http) {
    return {
        GetRequests: function () {
            url = baseAddress + "GetRequests";
            return $http.get(url);
        }
    };
});
app.controller('AppController', function PostController($scope, Factory) {
   
    window.root = $scope;
    $scope.Requests = [];
    $scope.editMode = false;
    //Get All Prior Approval Requests
    $scope.getAll = function () {
        Factory.GetRequests().success(function (data) {
            $scope.Requests = data;
            //alert($scope.users);
        }).error(function (data) {
            $scope.error = "An Error has occured while Loading users! " + data.ExceptionMessage;
        });
    };
    $scope.getAll();

});