- The goal is to create an application through which the user can add, modify and delete, in addition to printing
- There are classes, they are: View, Model, View Model.
- Override the ToString method in Model classes to print all details inside the method, for example inside the User id, name, age, and inside the StaffUser id, name, age, role, and inside the AdminUser id, name, age , staffUse and so on..
- Equals method: to compare and make sure that each person's information is different from the other, for example the private id in the user is different from the private id in the staffUse means that the user is a different person from the staffUse and so on .. but the information must be the same in the event that a comparison is made staffUse with staffUse because it has the same ID, name, age, role.
- The Role attribute in staffUser is an enum that accepts [Role1,Role2,Role3].
- The throw exceptions was used to ensure that the program works correctly, specifically when an error occurs, as every id, exception name, and age are checked.
DuplicateIdExpction: If the entry is duplicated
InValidDataExpction: If the entry is invalid
NotFoundExpction: If the entry does not exist
- In the event of any change or modification to the User, StaffUser, and AdminUser (inside the model), the view is modified using a method called delegate.
- In the view, any expression is printed on the back.
- -----
In the manual, the program prints a menu that appears to the user asking him to enter the type of user. If the user chooses the number 1, he chooses the user list, and if he chooses the number 2, he chooses the staffUse list, and if he chooses the number 3, he chooses the AdminUse list.

In addition, a menu appears for the user to choose the operation, which is done by choosing a specific letter
Such as the letter A to complete the addition process, the letter E to complete the modification process, the letter D to complete the deletion process, and the letter E to complete the exit process.
And certainly every time the inputs are checked, checked and compared with each other, and in the event of any error, an explanatory message is printed to the user (partial throw exceptions).
