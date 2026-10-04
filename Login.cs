using System;

public class Login
{
    public bool LoginUser(string username, string password)
    {
        Console.WriteLine($"Đang đăng nhập với tài khoản: {username}");

        if (username == "admin" && password == "123456")
        {
            Console.WriteLine("Đăng nhập thành công!");
            return true;
        }

        Console.WriteLine("Đăng nhập thất bại!");
        return false;
    }
}