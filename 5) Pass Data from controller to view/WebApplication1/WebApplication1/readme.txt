Passing Data From Controller To


· You can use the following objects to pass
data between controller and view:
1. ViewData
2. ViewBag
3. TempData
4. Strongly Typed Views

-------------
1. ViewData
-------------
The general syntax of ViewData is as follows:

ViewData["<Key>"] = <Value>;

• It passes data from a controller to a view.
• Is a dictionary of objects that is derived from the ViewDataDictionary class.

Some of the characteristics of ViewData are as follows:
• The life of a ViewData object exists only during the current request.
• The value of ViewData becomes null if the request is redirected.
• ViewData requires typecasting when you use complex data type to avoid error.

Note:
ViewData does not provide compile time error checking.
For example — if you misspell keys, you wouldn’t get any compile time errors.
You get to know about the error only at runtime.
// only access in which view where it define
//need typecasting

-------------
1. ViewBag
-------------
· The general syntax of ViewBag is as follows:
. ViewBag.<PropertyName> = <Value>;

// only access in which view where it define
//dont need typecasting

-------------
1. TempData
-------------

only one time accessable 
chahe apny pr access kro agr dusry pr bh kro to hojae ga requires redirect fro where it defined
yeh agr  eg about controller my define h or call kr ra hun index pr to show hoga only one time use Keep if you want it is abvaialble
// need typecasting