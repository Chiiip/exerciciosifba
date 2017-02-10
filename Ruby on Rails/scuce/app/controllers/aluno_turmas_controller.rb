class AlunoTurmasController < ApplicationController
  before_action :set_aluno_turma, only: [:show, :edit, :update, :destroy]

  # GET /aluno_turmas
  # GET /aluno_turmas.json
  def index
    @aluno_turmas = AlunoTurma.all
  end

  # GET /aluno_turmas/1
  # GET /aluno_turmas/1.json
  def show
  end

  # GET /aluno_turmas/new
  def new
    @aluno_turma = AlunoTurma.new
  end

  # GET /aluno_turmas/1/edit
  def edit
  end

  # POST /aluno_turmas
  # POST /aluno_turmas.json
  def create
    @aluno_turma = AlunoTurma.new(aluno_turma_params)

    respond_to do |format|
      if @aluno_turma.save
        format.html { redirect_to @aluno_turma, notice: 'Aluno turma was successfully created.' }
        format.json { render :show, status: :created, location: @aluno_turma }
      else
        format.html { render :new }
        format.json { render json: @aluno_turma.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /aluno_turmas/1
  # PATCH/PUT /aluno_turmas/1.json
  def update
    respond_to do |format|
      if @aluno_turma.update(aluno_turma_params)
        format.html { redirect_to @aluno_turma, notice: 'Aluno turma was successfully updated.' }
        format.json { render :show, status: :ok, location: @aluno_turma }
      else
        format.html { render :edit }
        format.json { render json: @aluno_turma.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /aluno_turmas/1
  # DELETE /aluno_turmas/1.json
  def destroy
    @aluno_turma.destroy
    respond_to do |format|
      format.html { redirect_to aluno_turmas_url, notice: 'Aluno turma was successfully destroyed.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_aluno_turma
      @aluno_turma = AlunoTurma.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def aluno_turma_params
      params.require(:aluno_turma).permit(:numfaltas, :turma_id, :turma_name, :aluno_id, :aluno_name)
    end
end
