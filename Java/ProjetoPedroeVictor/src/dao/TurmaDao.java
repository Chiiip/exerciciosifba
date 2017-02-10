/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package dao;

import banco.Banco;
import dto.TurmaDto;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JComboBox;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import projetopedroevictor.CadastroAlunos;
import projetopedroevictor.PesquisaAluno;
import projetopedroevictor.PesquisaTurma;
import projetopedroevictor.Telaprincipal;


public class TurmaDao {

public char anterior;

public void inserir (TurmaDto obj){
Banco objBanco = new Banco();    



String nometurma = obj.getNometurma();
String turno = obj.getTurno();



objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("INSERT into turma (nome_turma, turno) VALUES (?,?)");
       
        
        objPst.setString(1, nometurma);
        objPst.setString(2, turno);

        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do insert!"+ex.getMessage());
    }
}    
public void alterar(TurmaDto obj){
Banco objBanco = new Banco();    


int codturma = obj.getCodturma();
String nometurma = obj.getNometurma();
String turno = obj.getTurno();


objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("UPDATE turma set nometurma = ?, turno = ?"
                + "where cod_turma= ?");
       
        objPst.setString(1, nometurma);
        objPst.setString(2, turno);
        objPst.setInt(3, codturma);
       

        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando alterar executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do update!"+ex.getMessage());
    }
} 
public void deletar(TurmaDto obj){
Banco objBanco = new Banco();    

int codturma = obj.getCodturma();

objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("DELETE FROM turma"
                + "WHERE cod_turma = ?");
       

        objPst.setInt(1, codturma); 
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

        PreparedStatement objPst = objBanco.con.prepareStatement("select cod_turma, nome_turma FROM turma"); 
     
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
    PesquisaTurma.jTable1.setModel(modelo);
             
            
        
             
        
        
        
        }    
     
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do select!"+ex.getMessage());
    } 
    
}   



}
