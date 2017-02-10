/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package dao;

import banco.Banco;
import dto.ProfessorDto;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
/**
 *
 * @author Pedro Augusto
 */
public class ProfessorDao {
 
public void inserir (ProfessorDto obj){
Banco objBanco = new Banco();    


int codprofessor = obj.getCodprofessor();
String nome = obj.getNome();
Date datadenascimento = obj.getDatadenascimento();
long rg = obj.getRg();
long cpf = obj.getCPF();
String endereco = obj.getEndereco();
long telefone = obj.getTelefone();
String email = obj.getEmail();
String senha = obj.getSenha(); 
char adm = obj.getAdm();


objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("INSERT into professor (cod_professor, nome, datadenascimento, rg, cpf,"
                + "endereco, telefone, email, senha, adm) VALUES (?,?,?,?,?,?,?,?,?,?");
       
        objPst.setInt(1, codprofessor);
        objPst.setString(2, nome);
        objPst.setDate(3, datadenascimento);
        objPst.setLong(4, rg);
        objPst.setLong(5, cpf);
        objPst.setString(6, endereco);
        objPst.setLong(7, telefone);
        objPst.setString(8, email);
        objPst.setString(9, senha);
        objPst.setString(10, String.valueOf(adm));

        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do insert!"+ex.getMessage());
    }
}    
public void alterar(ProfessorDto obj){
Banco objBanco = new Banco();    


int codprofessor = obj.getCodprofessor();
String nome = obj.getNome();
Date datadenascimento = obj.getDatadenascimento();
long rg = obj.getRg();
long cpf = obj.getCPF();
String endereco = obj.getEndereco();
long telefone = obj.getTelefone();
String email = obj.getEmail();
String senha = obj.getSenha(); 
char adm = obj.getAdm();


objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("UPDATE professor set nome = ?, datadenascimento = ?, rg = ?, cpf = ?"
                + "endereco = ?, telefone = ?, email= ?, senha = ?, adm = ?"
                + "where cod_professor = ?");
       

        objPst.setString(1, nome);
        objPst.setDate(2, datadenascimento);
        objPst.setLong(3, rg);
        objPst.setLong(4, cpf);
        objPst.setString(5, endereco);
        objPst.setLong(6, telefone);
        objPst.setString(7, email);
        objPst.setString(8, senha);
        objPst.setString(9, String.valueOf(adm));
        objPst.setInt(10, codprofessor);

        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando alterar executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do update!"+ex.getMessage());
    }
}     
public void deletar(ProfessorDto obj){
Banco objBanco = new Banco();    

int codprofessor = obj.getCodprofessor();

objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("DELETE FROM professor"
                + "WHERE cod_professor = ?");
       

        objPst.setInt(1, codprofessor); 
        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando deletar executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do delete!"+ex.getMessage());
    }        
}    

public ResultSet selecionar(){
Banco objBanco = new Banco();    
objBanco.conectar();    
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("select professor.* FROM professor");        
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
    
