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
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import projetopedroevictor.PesquisaAluno;
import projetopedroevictor.PesquisaProfessor;
import projetopedroevictor.Telaprincipal;
/**
 *
 * @author Pedro Augusto
 */
public class ProfessorDao {   
public char anterior;

public void inserir (ProfessorDto obj){
Banco objBanco = new Banco();    


String nome = obj.getNome();
Date datadenascimento = obj.getDatadenascimento();
long rg = obj.getRg();
long cpf = obj.getCPF();
String endereco = obj.getEndereco();
long telefone = obj.getTelefone();
String email = obj.getEmail();
String senha = obj.getSenha(); 
char adm = 0;



objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("INSERT into professor (nome, datadenascimento, rg, cpf,"
                + "endereco, telefone, email, senha, adm) VALUES (?,?,?,?,?,?,?,?,?)");
       
        objPst.setString(1, nome);
        objPst.setDate(2, datadenascimento);
        objPst.setLong(3, rg);
        objPst.setLong(4, cpf);
        objPst.setString(5, endereco);
        objPst.setLong(6, telefone);
        objPst.setString(7, email);
        objPst.setString(8, senha);
        objPst.setString(9, String.valueOf(adm));

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



objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("UPDATE professor set nome = ?, datadenascimento = ?, rg = ?, cpf = ?"
                + "endereco = ?, telefone = ?, email= ?, senha = ?"
                + "where cod_professor = ?");
       

        objPst.setString(1, nome);
        objPst.setDate(2, datadenascimento);
        objPst.setLong(3, rg);
        objPst.setLong(4, cpf);
        objPst.setString(5, endereco);
        objPst.setLong(6, telefone);
        objPst.setString(7, email);
        objPst.setString(8, senha);
        objPst.setInt(9, codprofessor);

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

public void selecionar(){
Banco objBanco = new Banco();    
objBanco.conectar();    
    try {
        
        String[] tableColumnsName = {"Nome", "RG", "CPF", "Telefone"};
        
    DefaultTableModel aModel = (DefaultTableModel) PesquisaProfessor.jTable1.getModel();
aModel.setColumnIdentifiers(tableColumnsName);



        PreparedStatement objPst = objBanco.con.prepareStatement("select nome,rg,cpf,telefone FROM professor");
        
        
        ResultSet objRst = objPst.executeQuery();
        
        ResultSetMetaData metaData = objPst.getMetaData();
        Vector<String> columnNames = new Vector<String>();
    int columnCount = metaData.getColumnCount();
    for (int column = 1; column <= columnCount; column++) {
        columnNames.add(metaData.getColumnName(column));
    }

    // data of the table
    Vector<Vector<Object>> data = new Vector<Vector<Object>>();
    while (objRst.next()) {
        Vector<Object> vector = new Vector<Object>();
        for (int columnIndex = 1; columnIndex <= columnCount; columnIndex++) {
            vector.add(objRst.getObject(columnIndex));
        }
        data.add(vector);
    }

    DefaultTableModel modelo = new DefaultTableModel(data, columnNames);
    PesquisaProfessor.jTable1.setModel(modelo);
        
        
        }    
     
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do select!"+ex.getMessage());
    } 
    
}   
}


    
