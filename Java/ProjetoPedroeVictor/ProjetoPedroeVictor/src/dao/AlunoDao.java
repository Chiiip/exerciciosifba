/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package dao;

import banco.Banco;
import dto.AlunoDto;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

public class AlunoDao {

public void inserir (AlunoDto obj){
Banco objBanco = new Banco();    


int codaluno = obj.getCodaluno();
int codturma = obj.getCodturma();
String nome = obj.getNome();
Date datadenascimento = obj.getDatadenascimento();
long rg = obj.getRg();
String endereco = obj.getEndereco();
char genero = obj.getGenero();
long telefone = obj.getTelefone();
String nomepai = obj.getNomepai();
String nomemae = obj.getNomemae();
long telefonepai = obj.getTelefonepai();
long telefonemae = obj.getTelefonemae();
String email = obj.getEmail();
String senha = obj.getSenha();


objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("INSERT into aluno (cod_aluno, cod_turma, nome, datadenascimento, rg,"
                + "endereco, genero, telefone, nomepai, nomemae, telefonepai, telefonemae, email, senha) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?)");
       
        objPst.setInt(1, codaluno);
        objPst.setInt(2, codturma);
        objPst.setString(3, nome);
        objPst.setDate(4, datadenascimento);
        objPst.setLong(5, rg);
        objPst.setString(6, endereco);
        objPst.setString(7, String.valueOf(genero));
        objPst.setLong(8, telefone);
        objPst.setString(9, nomepai);
        objPst.setString(10, nomemae);
        objPst.setLong(11, telefonepai);
        objPst.setLong(12, telefonemae);
        objPst.setString(13, email);
        objPst.setString(14, senha);

        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do insert!"+ex.getMessage());
    }
}    
    
public void alterar (AlunoDto obj){
Banco objBanco = new Banco();    


int codaluno = obj.getCodaluno();
int codturma = obj.getCodturma();
String nome = obj.getNome();
Date datadenascimento = obj.getDatadenascimento();
long rg = obj.getRg();
String endereco = obj.getEndereco();
char genero = obj.getGenero();
long telefone = obj.getTelefone();
String nomepai = obj.getNomepai();
String nomemae = obj.getNomemae();
long telefonepai = obj.getTelefonepai();
long telefonemae = obj.getTelefonemae();
String email = obj.getEmail();
String senha = obj.getSenha();


objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("UPDATE aluno set cod_turma = ?, nome = ?, datadenascimento = ?, rg = ?,"
                + "endereco = ?, genero = ?, telefone = ?, nomepai = ?, nomemae = ?, telefonepai = ?, telefonemae = ?, email= ?, senha = ?"
                + "where cod_aluno = ?");
       
        objPst.setInt(1, codturma);
        objPst.setString(2, nome);
        objPst.setDate(3, datadenascimento);
        objPst.setLong(4, rg);
        objPst.setString(5, endereco);
        objPst.setString(6, String.valueOf(genero));
        objPst.setLong(7, telefone);
        objPst.setString(8, nomepai);
        objPst.setString(9, nomemae);
        objPst.setLong(10, telefonepai);
        objPst.setLong(11, telefonemae);
        objPst.setString(12, email);
        objPst.setString(13, senha);
        objPst.setInt(14, codaluno);

        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando alterar executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do update!"+ex.getMessage());
    }
}     

public void deletar(AlunoDto obj){
Banco objBanco = new Banco();    

int codaluno = obj.getCodaluno();

objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("DELETE FROM aluno"
                + "WHERE cod_aluno = ?");
       

        objPst.setInt(1, codaluno); 
        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando deletar executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do delete!"+ex.getMessage());
    }        
}

public ResultSet selecionar() {
Banco objBanco = new Banco();    
objBanco.conectar();    
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("select aluno.* FROM aluno");        
        ResultSet objRst = objPst.executeQuery();
        JOptionPane.showMessageDialog(null, "Comando selecionar executado com sucesso!");       
        return objRst;
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do select!"+ex.getMessage());
    } 
    return null;
}    
    
}
