# git_search
Search Git Hub repository


1.this is an  a GitHub repositories search page using their API.

 Technologies: AngularJS, MVC.NET, Bootstrap
 
 You need WIN server /PC, IIS  to run this site.
 (site include some links to external files sutch angularJs etc.


2.When searching(by pressing a button or using the Enter key) it will perform a request to:

https://api.github.com/search/repositories?q=_SEARCH_KEYWORD  by click with the mouse or by Enter.

3.results render  as gallery items where each item will show to repository name, avatar of the owner and a bookmark button.

4.When a user will bookmark a repository it will store the entire result to the user's session( ASP.NET session).

5.Second page is bookmark screen that  show all the bookmarked repositories (by clicking the menu)

Gilad Dolev
