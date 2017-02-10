/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package dto;

/**
 *
 * @author Pedro Augusto
 */
public class MateriaDto {
private String nome;
private int codmateria;

    /**
     * @return the nome
     */
    public String getNome() {
        return nome;
    }

    /**
     * @param nome the nome to set
     */
    public void setNome(String nome) {
        this.nome = nome;
    }

    /**
     * @return the codmateria
     */
    public int getCodmateria() {
        return codmateria;
    }

    /**
     * @param codmateria the codmateria to set
     */
    public void setCodmateria(int codmateria) {
        this.codmateria = codmateria;
    }

}
