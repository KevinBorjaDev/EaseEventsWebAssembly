public class UserSessionService
{
    private UserModel _registeredUser;
    private bool _isUserLoggedIn;

    // Lista de observadores
    private readonly List<Action<bool>> _observers = new();

    public void RegisterUser(UserModel user)
    {
        _registeredUser = user;
    }

    public UserModel GetCurrentUser()
    {
        return _registeredUser;
    }

    public void Login()
    {
        _isUserLoggedIn = true;
        NotifyObservers();
    }

    public bool IsUserLoggedIn()
    {
        return _isUserLoggedIn;
    }

    public void Logout()
    {
        _isUserLoggedIn = false;
        NotifyObservers();
    }

    public void Subscribe(Action<bool> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }

    public void Unsubscribe(Action<bool> observer)
    {
        if (_observers.Contains(observer))
        {
            _observers.Remove(observer);
        }
    }

    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer(_isUserLoggedIn);
        }
    }
}
