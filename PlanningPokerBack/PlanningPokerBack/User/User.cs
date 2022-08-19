partial class User
{
    private int Id {get; set;}
    private string NickName {get; set}


    private UserRole CurrentRole {get; set;}
    private UserStatus CurrentStatus {get; set;}


    public User (string nikName)
    {
        Id = 1000;
        NickName = nikName;
        CurrentRole = UserRole.RegularUser;
        CurrentStatus = UserStatus.Unconfirmed;

    }

    public void Vote() /// append Estiamte 
    {
    // return  estimate; 
    }
     
    





}