/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package dto;

import java.sql.Date;

/**
 *
 * @author Pedro Augusto
 */
public class AlunoDto {

private int codaluno;
private String codturma;
private String nome;
private Date datadenascimento;
private long rg;
private String endereco;
private String genero;
private long telefone;
private String nomepai;
private String nomemae;
private long telefonepai;
private long telefonemae;
private String email;
private String senha;
private String nometurma;
private int codturma2;

    /**
     * @return the codaluno
     */
    public int getCodaluno() {
        return codaluno;
    }

    public int getValor() {
        return 2;
    }
    /**
     * @param codaluno the codaluno to set
     */
    public void setCodaluno(int codaluno) {
        this.codaluno = codaluno;
    }

    /**
     * @return the codturma
     */
    public String getCodturma() {
        return codturma;
    }

    /**
     * @param codturma the codturma to set
     */
    public void setCodturma(String codturma) {
        this.codturma = codturma;
    }

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
     * @return the datadenascimento
     */
    public Date getDatadenascimento() {
        
     return datadenascimento;
    }

    /**
     * @param datadenascimento the datadenascimento to set
     */
    public void setDatadenascimento(Date datadenascimento) {
        this.datadenascimento = datadenascimento;
    }

    /**
     * @return the rg
     */
    public long getRg() {
        return rg;
    }

    /**
     * @param rg the rg to set
     */
    public void setRg(long rg) {
        this.rg = rg;
    }

    /**
     * @return the endereco
     */
    public String getEndereco() {
        return endereco;
    }

    /**
     * @param endereco the endereco to set
     */
    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    /**
     * @return the genero
     */
    public String getGenero() {
        return genero;
    }

    /**
     * @param genero the genero to set
     */
    public void setGenero(String genero) {
        this.genero = genero;
    }

    /**
     * @return the telefone
     */
    public long getTelefone() {
        return telefone;
    }

    /**
     * @param telefone the telefone to set
     */
    public void setTelefone(long telefone) {
        this.telefone = telefone;
    }

    /**
     * @return the nomepai
     */
    public String getNomepai() {
        return nomepai;
    }

    /**
     * @param nomepai the nomepai to set
     */
    public void setNomepai(String nomepai) {
        this.nomepai = nomepai;
    }

    /**
     * @return the nomemae
     */
    public String getNomemae() {
        return nomemae;
    }

    /**
     * @param nomemae the nomemae to set
     */
    public void setNomemae(String nomemae) {
        this.nomemae = nomemae;
    }

    /**
     * @return the telefonepai
     */
    public long getTelefonepai() {
        return telefonepai;
    }

    /**
     * @param telefonepai the telefonepai to set
     */
    public void setTelefonepai(long telefonepai) {
        this.telefonepai = telefonepai;
    }

    /**
     * @return the telefonemae
     */
    public long getTelefonemae() {
        return telefonemae;
    }

    /**
     * @param telefonemae the telefonemae to set
     */
    public void setTelefonemae(long telefonemae) {
        this.telefonemae = telefonemae;
    }

    /**
     * @return the telefonealuno
     */
   

    /**
     * @return the email
     */
    public String getEmail() {
        return email;
    }

    /**
     * @param email the email to set
     */
    public void setEmail(String email) {
        this.email = email;
    }

    /**
     * @return the senha
     */
    public String getSenha() {
        return senha;
    }

    /**
     * @param senha the senha to set
     */
    public void setSenha(String senha) {
        this.senha = senha;
    }

    /**
     * @return the nometurma
     */
    public String getNometurma() {
        return nometurma;
    }

    /**
     * @param nometurma the nometurma to set
     */
    public void setNometurma(String nometurma) {
        this.nometurma = nometurma;
    }

    /**
     * @return the codturma2
     */
    public int getCodturma2() {
        return codturma2;
    }

    /**
     * @param codturma2 the codturma2 to set
     */
    public void setCodturma2(int codturma2) {
        this.codturma2 = codturma2;
    }

}
