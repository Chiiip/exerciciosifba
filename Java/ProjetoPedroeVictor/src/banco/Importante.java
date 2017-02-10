package banco;

/**
 *
 * @author Victor
 */
public class Importante {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Banco objBanco = new Banco();
        objBanco.conectar();
        objBanco.executarComando("");
        objBanco.desconectar();
    }
}
