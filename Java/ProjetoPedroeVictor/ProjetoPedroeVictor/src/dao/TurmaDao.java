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
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;


public class TurmaDao {

public void inserir (TurmaDto obj){
Banco objBanco = new Banco();    


int codturma = obj.getCodturma();
String nometurma = obj.getNometurma();
String turno = obj.getTurno();



objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("INSERT into turma (cod_turma, nometurma, turno) VALUES (?,?,?)");
       
        objPst.setInt(1, codturma);
        objPst.setString(2, nometurma);
        objPst.setString(3, turno);

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

public ResultSet selecionar(){
Banco objBanco = new Banco();    
objBanco.conectar();    
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("select turma.* FROM turma");        
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
