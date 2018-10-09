debugger
var app = angular.module('app', []);
//directives
app.directive("search", function () {
    return {
        templateUrl: '../directive/search.html'
    };
});

//main app
app.controller('ctrl', function ($scope, $http, $document, $filter, $interval, $timeout, $window) {
    let scope = $scope;
    //default page
    $scope.page = 'git';
    $scope.searchKey = '';
    //search data at Git repository
    $scope.search = () => {
        let url = "https://api.github.com/search/repositories?q=";
        $http.get(url + $scope.searchKey).then(function (res) {
            $scope.data = res.data.items;
        })
        //clen for new search
        $scope.showSearch = ()=>{
            $scope.data = [];
        }
        //save book mark at session
        $scope.saveItem = (item) => {
            let Jitem = JSON.stringify(item);
            $http.post('/Home/Save', { jItem: Jitem });

        }
        //get book marks from session
        $scope.showList = () => {
            //clean search
            $scope.searchKey = '';
            $http.get(`/Home/List`).then(function (res) {
                $scope.data = res.data;
            })
        }

    }

});
