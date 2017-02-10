/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package dao;

import java.sql.Date;
import banco.Banco;
import dto.AulaDto;
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
public class AulaDao {

 public void inserir (AulaDto obj){
Banco objBanco = new Banco();    


int codaula = obj.getCodaula();
Date dia = obj.getDia();
String horario = obj.getHorario();
String materia = obj.getMateria(); 
int codturma = obj.getCodturma();


objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("INSERT into aulaextra (codaula, dia, horario, materia, codturma)"
                + " VALUES (?,?,?,?,?)");
       
        objPst.setInt(1, codaula);
        objPst.setDate(2, dia);
        objPst.setString(3, horario);
        objPst.setString(4, materia);
        objPst.setInt(5, codturma);

        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do insert!"+ex.getMessage());
    }
}    
public void alterar(AulaDto obj){
Banco objBanco = new Banco();    

int codaula = obj.getCodaula();
Date dia = obj.getDia();
String horario = obj.getHorario();
String materia = obj.getMateria(); 
int codturma = obj.getCodturma();



objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("UPDATE aulaextra set dia= ?, horario = ?, materia = ?, codturma = ?"
                + "where cod_aula = ?");
       

       
        objPst.setDate(1, dia);
        objPst.setString(2, horario);
        objPst.setString(3, materia);
        objPst.setInt(4, codturma);
        objPst.setInt(5, codaula);

        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando alterar executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do update!"+ex.getMessage());
    }
}     

public void deletar(AulaDto obj){
Banco objBanco = new Banco();    

int codaula = obj.getCodaula();

objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("DELETE FROM aulaextra"
                + "WHERE cod_aula = ?");
       

        objPst.setInt(1, codaula); 
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
        PreparedStatement objPst = objBanco.con.prepareStatement("select aulaextra.* FROM aulaextra");        
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