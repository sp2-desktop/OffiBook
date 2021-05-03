using MySql.Data.MySqlClient;

public class Bdd
{

    private MySqlConnection connection;

    // Constructeur
    public Bdd()
    {
        this.InitConnexion();
    }

    // Méthode pour initialiser la connexion
    private void InitConnexion()
    {
        // Création de la chaîne de connexion
        string connectionString = "SERVER=127.0.0.1; DATABASE=offibook_v0; UID=root; PASSWORD=";
        this.connection = new MySqlConnection(connectionString);
    }

    // Méthode pour ajouter un contact
    public void AddUser(offibook_v0.User user)
    {
        try
        {
            // Ouverture de la connexion SQL
            this.connection.Open();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = this.connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "INSERT INTO contact (id, login, password) VALUES (@id, @login, @password)";

            // utilisation de l'objet contact passé en paramètre
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Parameters.AddWithValue("@name", user.login);
            cmd.Parameters.AddWithValue("@tel", user.password);

            // Exécution de la commande SQL
            cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            this.connection.Close();
        }
        catch
        {
            // Gestion des erreurs :
            // Possibilité de créer un Logger pour les exceptions SQL reçus
            // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
        }
    }
}