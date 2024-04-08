namespace API;

public interface IHelperClass
{
    bool ComaprePassword(string sendingPassword, byte[] passwordSalt, byte[] passwordHash);

}
