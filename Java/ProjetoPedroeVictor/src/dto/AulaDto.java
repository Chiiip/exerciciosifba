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
public class AulaDto {
private int codaula;
private Date dia;
private String horario;
private String materia;
private int codturma;

    /**
     * @return the codaula
     */
    public int getCodaula() {
        return codaula;
    }

    /**
     * @param codaula the codaula to set
     */
    public void setCodaula(int codaula) {
        this.codaula = codaula;
    }

    /**
     * @return the dia
     */
    public Date getDia() {
        return dia;
    }

    /**
     * @param dia the dia to set
     */
    public void setDia(Date dia) {
        this.dia = dia;
    }

    /**
     * @return the horario
     */
    public String getHorario() {
        return horario;
    }

    /**
     * @param horario the horario to set
     */
    public void setHorario(String horario) {
        this.horario = horario;
    }

    /**
     * @return the materia
     */
    public String getMateria() {
        return materia;
    }

    /**
     * @param materia the materia to set
     */
    public void setMateria(String materia) {
        this.materia = materia;
    }

    /**
     * @return the codturma
     */
    public int getCodturma() {
        return codturma;
    }

    /**
     * @param codturma the codturma to set
     */
    public void setCodturma(int codturma) {
        this.codturma = codturma;
    }

}