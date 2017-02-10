package banco;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

public class Banco {

    String url = "jdbc:sqlserver://localhost:1433;databaseName=SECNATESTE";
    String usuario = "sa";
    String senha = "123456";
    public Connection con;

    public void conectar() {
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            
        } catch (ClassNotFoundException ex) {
            JOptionPane.showMessageDialog(null, "A classe não foi encontrada" + ex.getMessage());
        }
        try {
            this.con = DriverManager.getConnection(url, usuario, senha);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Conexão não estabelecida" + ex.getMessage());
        }
    }

    public void desconectar() {
        try {
            this.con.close();
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Não foi possível desconectar" + ex.getMessage());
        }

    }

    public void executarComando(String sql) {

        try {
            Statement objs = this.con.createStatement();
            objs.execute(sql);
            JOptionPane.showMessageDialog(null, "Comando realizado com sucesso!!");
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro na tentativa de ligação!" + ex.getMessage());

        }
        

    }
    
    public ResultSet executarConsulta(String sql) {

        try {
            Statement objs = this.con.createStatement();
            ResultSet objRs = objs.executeQuery(sql);
            JOptionPane.showMessageDialog(null, "Consulta realizada com sucesso!!");
            return objRs;
        } catch (SQLException ex) {
             JOptionPane.showMessageDialog(null, "Erro na tentativa de ligação!" + ex.getMessage());

        }
        return null;
    }


}


