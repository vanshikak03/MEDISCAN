using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;

    // This method is called when the login button is clicked
    public void OnLoginButtonClicked()
    {
        // Basic validation for demonstration purposes
        string username = usernameInput.text;
        string password = passwordInput.text;

        // Validate the credentials
        if (ValidateCredentials(username, password))
        {
            // Successful login, proceed to the next scene
            Debug.Log("Login successful!");
            // Use the Instance property of SceneTransitionManager to access the singleton instance
            SceneTransitionManager.Instance.GoToScene(2);
        }
        else
        {
            // Invalid credentials, show error message
            Debug.Log("Invalid username or password");
        }
    }

    // Method to validate the entered username and password
    private bool ValidateCredentials(string username, string password)
    {
        // Replace this with your actual validation logic
        return username == "admin" && password == "password";
    }
}
