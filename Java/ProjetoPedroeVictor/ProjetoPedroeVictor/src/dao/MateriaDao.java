/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package dao;

import banco.Banco;
import dto.MateriaDto;
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
public class MateriaDao {
 
public void inserir (MateriaDto obj){
Banco objBanco = new Banco();    

String nome = obj.getNome();
int codmateria = obj.getCodmateria();

objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("INSERT into materia (nome, cod_materia) VALUES (?,?)");
       
        objPst.setString(1, nome);
        objPst.setInt(2, codmateria);
        
        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do insert!"+ex.getMessage());
    }
}    
    
public void alterar (MateriaDto obj){
Banco objBanco = new Banco();    

String nome = obj.getNome();
int codmateria = obj.getCodmateria();

objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("UPDATE materia SET nome = ?"
                + "WHERE cod_materia = ?");
       
        objPst.setString(1, nome);
        objPst.setInt(2, codmateria);
        
        objPst.execute();
        JOptionPane.showMessageDialog(null, "Comando alterar executado com sucesso!");
        
    } 
    
    catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Erro na execução do update!"+ex.getMessage());
    }    
}   

public void deletar(MateriaDto obj){
Banco objBanco = new Banco();    

int codmateria = obj.getCodmateria();

objBanco.conectar();
    try {
        PreparedStatement objPst = objBanco.con.prepareStatement("DELETE FROM materia"
                + "WHERE cod_materia = ?");
       

        objPst.setInt(1, codmateria); 
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
        PreparedStatement objPst = objBanco.con.prepareStatement("select materia.* FROM materia");        
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
