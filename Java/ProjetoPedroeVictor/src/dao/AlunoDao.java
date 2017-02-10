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
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import projetopedroevictor.CadastroAlunos;
import projetopedroevictor.PesquisaAluno;
import projetopedroevictor.Telaprincipal;

public class AlunoDao {

public char anterior;    


public void inserir (AlunoDto obj){
Banco objBanco = new Banco();    


String nomealuno = obj.getCodturma();
String nometurma = obj.getCodturma();
String nome = obj.getNome();
Date datadenascimento = obj.getDatadenascimento();
long rg = obj.getRg();
String endereco = obj.getEndereco();
String genero = obj.getGenero();
long telefone = obj.getTelefone();
String nomepai = obj.getNomepai();
String nomemae = obj.getNomemae();
long telefonepai = obj.getTelefonepai();
long telefonemae = obj.getTelefonemae();
String email = obj.getEmail();
String senha = obj.getSenha();


objBanco.conectar();
    try {
        
        PreparedStatement objPst2 = objBanco.con.prepareStatement("SELECT COD_TURMA from turma where nome_turma = ?");
        objPst2.setString(1, nometurma);
        
        ResultSet codigo = objPst2.executeQuery();
        codigo.next();
        int codturma = codigo.getInt(1);
        
        
        PreparedStatement objPst = objBanco.con.prepareStatement("INSERT into aluno (cod_turma, nome, datadenascimento, rg,"
                + "endereco, genero, telefone, nomepai, nomemae, telefonepai, telefonemae, email, senha) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)");
       
        
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

        objPst.execute();
        
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do insert!"+ex.getMessage());
    }
}    
    
public void alterar (AlunoDto obj){
Banco objBanco = new Banco();    


int codaluno = obj.getCodaluno();
String nometurma = obj.getCodturma();
String nome = obj.getNome();
Date datadenascimento = obj.getDatadenascimento();
long rg = obj.getRg();
String endereco = obj.getEndereco();
String genero = obj.getGenero();
long telefone = obj.getTelefone();
String nomepai = obj.getNomepai();
String nomemae = obj.getNomemae();
long telefonepai = obj.getTelefonepai();
long telefonemae = obj.getTelefonemae();
String email = obj.getEmail();
String senha = obj.getSenha();


objBanco.conectar();
    try {
        
        PreparedStatement objPst2 = objBanco.con.prepareStatement("SELECT COD_TURMA from turma where nome_turma = ?");
        objPst2.setString(1, nometurma);
        
        ResultSet codigo = objPst2.executeQuery();
        int codturma = codigo.getInt(1);
        
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

public void selecionar() {
Banco objBanco = new Banco();    
objBanco.conectar();    
    try {
        


        PreparedStatement objPst = objBanco.con.prepareStatement("select aluno.nome, cod_aluno, turma.nome_turma, rg FROM aluno"
                + " inner join turma on aluno.cod_turma = turma.cod_turma");  
        
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
    PesquisaAluno.jTable1.setModel(modelo);
            
        }    
     
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do select!"+ex.getMessage());
    } 
    
}   

public void selecionardados() {
Banco objBanco = new Banco();    
objBanco.conectar();    
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("select aluno.nome, cod_aluno, turma.nome_turma, rg FROM aluno"
                + "inner join turma on aluno.cod_turma = turma.cod_turma"
                + "where aluno.nome like '?%'");  
        }    
     
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do select!"+ex.getMessage());
    } 
    
}

int malabarismo;

public void selecionarcombobox(AlunoDto obj){
Banco objBanco = new Banco();    
objBanco.conectar();    
    try {


        PreparedStatement objPst = objBanco.con.prepareStatement("select nome_turma, cod_turma FROM turma");

        ResultSet objRst = objPst.executeQuery();
        
        while (objRst.next()){
        CadastroAlunos.jComboBox1.addItem(objRst.getString("nome_turma"));    
        }      
        this.malabarismo = objRst.getInt(2);
        
        }    
     
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do select!"+ex.getMessage());
    } 
    
}

public void selecionaraluno(AlunoDto obj){
Banco objBanco = new Banco();    
objBanco.conectar();    
    try {
        String nome = obj.getNome();
        
          PreparedStatement objPst2 = objBanco.con.prepareStatement("SELECT COD_ALUNO from aluno where nome = ?");
        objPst2.setString(1, nome);
        
        ResultSet codigo = objPst2.executeQuery();
        codigo.next();
        int codaluno = codigo.getInt(1);
        System.out.println(codaluno);
        
        PreparedStatement objPst = objBanco.con.prepareStatement("select aluno.nome, turma.nome_turma, rg, datadenascimento,"
                + " endereco, genero, telefone, nomepai, nomemae,telefonepai, telefonemae, email from aluno"
                + " inner join turma on aluno.cod_turma = turma.cod_turma"
                + " where cod_aluno = ?");
        
        objPst.setInt(1, codaluno);

        ResultSet objRst = objPst.executeQuery();
        objRst.next();
        
        nome = objRst.getString(1);
        String nometurma = objRst.getString(2);
        long rg = objRst.getLong(3);
        Date datadenascimento = objRst.getDate(4);
        String endereco = objRst.getString(5);
        String genero = objRst.getString(6);
        long telefone = objRst.getLong(7);
        String nomepai = objRst.getString(8);
        String nomemae = objRst.getString(9);
        long telefonepai = objRst.getLong(10);
        long telefonemae = objRst.getLong(11);
        String email = objRst.getString(12);
        
        obj.setNome(nome);
        obj.setNometurma(nometurma);
        obj.setRg(rg);
        obj.setDatadenascimento(datadenascimento);
        obj.setEndereco(endereco);
        obj.setGenero(genero);
        obj.setTelefone(telefone);
        obj.setNomepai(nomepai);
        obj.setNomemae(nomemae);
        obj.setTelefonepai(telefonepai);
        obj.setTelefonemae(telefonemae);
        obj.setEmail(email);
        this.selecionarcombobox(obj);
        obj.setCodturma2(this.malabarismo);
        }    
     
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do select!"+ex.getMessage());
    } 
    
}

public void selecionaralunoboletim(AlunoDto obj){
Banco objBanco = new Banco();    
objBanco.conectar();    
    try {
        String nome = obj.getNome();
        
          PreparedStatement objPst2 = objBanco.con.prepareStatement("SELECT COD_ALUNO from aluno where nome = ?");
        objPst2.setString(1, nome);
        
        ResultSet codigo = objPst2.executeQuery();
        codigo.next();
        int codaluno = codigo.getInt(1);
        System.out.println(codaluno);
        
        PreparedStatement objPst = objBanco.con.prepareStatement("select aluno.nome, turma.nome_turma, cod_aluno from aluno"
                + " inner join turma on aluno.cod_turma = turma.cod_turma"
                + " where cod_aluno = ?");
        
        objPst.setInt(1, codaluno);

        ResultSet objRst = objPst.executeQuery();
        objRst.next();
        
        nome = objRst.getString(1);
        String nometurma = objRst.getString(2);
        int codaluno2 = objRst.getInt(3);

        obj.setNome(nome);
        obj.setNometurma(nometurma);
        obj.setCodaluno(codaluno2);
        
        
        }    
     
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do select!"+ex.getMessage());
    } 
    
}


}
