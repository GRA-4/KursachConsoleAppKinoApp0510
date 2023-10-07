// See https://aka.ms/new-console-template for more information
using WebApplicationKinoAPI0510;

Console.WriteLine("Hello, World!");


//var commonOperationsNew = new CommonOperations();
//Role newrole1 = new Role() { RoleName = "Admin "+TimeOnly.FromDateTime(DateTime.Now).ToString() };
//Role newrole2 = new Role() { RoleName = "User "+TimeOnly.FromDateTime(DateTime.Now).ToString() };
//var AddNewRoleAsync1 = await commonOperationsNew.AddEntityAsync<Role>(newrole1);
//var AddNewRoleAsync2 = await commonOperationsNew.AddEntityAsync<Role>(newrole2);


//User newuser1 = new User() { UserName = DateOnly.FromDateTime(DateTime.Now).ToString() + "newuser1", Email =  "UserUser", RoleId = 2 };
//User newuser2 = new User() { UserName = DateOnly.FromDateTime(DateTime.Now).ToString() + "newuser2", Email =  "UserUser", RoleId = 2 };
//User newuser3 = new User() { UserName = DateOnly.FromDateTime(DateTime.Now).ToString() + "newuser3", Email =  "UserUser", RoleId = 2 };
//User newuser4 = new User() { UserName = DateOnly.FromDateTime(DateTime.Now).ToString() + "newuser4", Email =  "UserUser", RoleId = 2 };
//User newuser5 = new User() { UserName = DateOnly.FromDateTime(DateTime.Now).ToString() + "newuser5", Email =  "asda", RoleId = 2 };
//User newuser6 = new User() { UserName = DateOnly.FromDateTime(DateTime.Now).ToString() + "newuser6", Email =  "asda", RoleId = 2 };
//var AddNewUserAsync1 = await commonOperationsNew.AddEntityAsync<User>(newuser1);
//var AddNewUserAsync2 = await commonOperationsNew.AddEntityAsync<User>(newuser2);
//var AddNewUserAsync3 = await commonOperationsNew.AddEntityAsync<User>(newuser3);
//var AddNewUserAsync4 = await commonOperationsNew.AddEntityAsync<User>(newuser4);
//var AddNewUserAsync5 = await commonOperationsNew.AddEntityAsync<User>(newuser5);
//var AddNewUserAsync6 = await commonOperationsNew.AddEntityAsync<User>(newuser6);


//Console.WriteLine($"Тупа глянь че есть\n\n");

//Console.WriteLine($"Получаешь по полю, которое содержит");
////Получаешь по полю, которое содержит
//var commonOperations01 = new CommonOperations();
//var usersWithAsd = await commonOperations01.GetAllByFieldContainsAsync<User>(u => u.Email, "asd");
//foreach (var user in usersWithAsd)
//{
//    Console.WriteLine($"User Id: {user.Id}, UserName: {user.UserName}");
//}



//Console.WriteLine($"Получаешь");
////Получаешь
//var commonOperations1 = new CommonOperations();
//var getUserById = await commonOperations1.GetByIdAsync<User>(1);

//Console.WriteLine($"User Id: {getUserById.Id}, UserName: {getUserById.UserName}");


//Console.WriteLine($"Получаешь всех");
////Получаешь всех
//var commonOperations2 = new CommonOperations();
//var getAllRolesAsync = await commonOperations2.GetAllAsync<Role>();

//foreach (var role in getAllRolesAsync)
//{
//    Console.WriteLine($"Role Id: {role.Id}, RoleName: {role.RoleName}");
//}

//Console.WriteLine($"Получаешь по полю");
////Получаешь по полю
//var commonOperations3 = new CommonOperations();
//var GetAllUsersByFieldAsync = await commonOperations3.GetAllByFieldAsync<User>(u => u.Email, "UserUser");

//foreach (var role in getAllRolesAsync)
//{
//    Console.WriteLine($"User Id: {getUserById.Id}, UserName: {getUserById.UserName}");
//}


//Console.WriteLine($"Добавляешь");
////Добавляешь
//var commonOperations4 = new CommonOperations();
//User user2 = new User() { UserName = DateTime.Now.ToString(), RoleId = 1 };
//var AddUserAsync = await commonOperations4.AddEntityAsync<User>(user2);

//Console.WriteLine($"User Id: {AddUserAsync.Id}, UserName: {AddUserAsync.UserName}");



//Console.WriteLine($"Обновляешь");
////Обновляешь
//var commonOperations5 = new CommonOperations();
//User user3 = new User() { Id = 5, UserName = DateTime.Now.ToString()+"123123" };
//var UpdateUserAsync = await commonOperations5.UpdateEntityAsync<User>(user3);

//Console.WriteLine($"User Id: {UpdateUserAsync.Id}, UserName: {UpdateUserAsync.UserName}");



//Console.WriteLine($"Удаляешь");
////Удаляешь
//var commonOperations6 = new CommonOperations();
////var getRoleById = await commonOperations6.GetByIdAsync<Role>(1);
////User user6 = new User() { Id = 12, UserName = DateTime.Now.ToString()+"123123" };


//var removeUser = await commonOperations6.UpdateEntityAsync<User>(new User { Id = 4, Password = "aasd" });
//if (removeUser != null)
//{
//    Console.WriteLine($"User Id: {removeUser.Id}, UserName: {removeUser.UserName}, User Email: {removeUser.Email}, User Role: {removeUser.Role.RoleName}");
//}


//Console.WriteLine($"\n\nКруто пиздец, да???????");





CommonOperations commonOperations = new CommonOperations();
var k = await commonOperations.GetAllAsync<Title>();
var d = await commonOperations.GetAllAsync<Genre>();


foreach (var title in k)
{
    Console.WriteLine($"Title Id: {title.Id}, UserName: {title.Genres.Count()}");
}










//var addUserAsync2 = await commonOperations6.AddEntityAsync<User>(new User {UserName = DateTime.Now.ToString()+"rrrr", Role = await commonOperations6.GetByIdAsync<Role>(1) });
//var GetUserById1 = await commonOperations6.GetByIdAsync<User>(20);
//GetUserById1.ImageUrl = "fdsfds";
//var updateUserAsync2 = await commonOperations6.UpdateEntityAsync<User>(GetUserById1);

//Console.WriteLine($"User Id: {addUserAsync2.Id}, UserName: {addUserAsync2.UserName}, User Email: {addUserAsync2.Email}, User Role: {addUserAsync2.Role.RoleName}");


//Console.WriteLine($"User Id: {updateUserAsync2.Id}, UserName: {updateUserAsync2.UserName}, User Email: {updateUserAsync2.Email}, User Role: {updateUserAsync2.Role.RoleName}");


////User user1 = new User() { Id = 11, UserName = DateOnly.FromDateTime(DateTime.Now).ToString() };
