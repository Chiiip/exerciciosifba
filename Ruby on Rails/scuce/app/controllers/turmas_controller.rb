class TurmasController < ApplicationController
  before_action :require_authentication, only: [:new, :edit, :create, :update, :destroy, :show, :index]
  before_action :set_turma, only: [:show, :edit, :update]
  # GET /turmas
  # GET /turmas.json
  def index
    @turmas = current_professor.turmas.all
  end

  # GET /turmas/1
  # GET /turmas/1.json
  def show
  end

  # GET /turmas/new
  def new
    @turma = Turma.new
  end

  # GET /turmas/1/edit
  def edit
  end

  # POST /turmas
  # POST /turmas.json
  def create
    @turma = Turma.new(turma_params)

    respond_to do |format|
      if @turma.save
        format.html { redirect_to @turma, notice: 'Turma was successfully created.' }
        format.json { render :show, status: :created, location: @turma }
      else
        format.html { render :new }
        format.json { render json: @turma.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /turmas/1
  # PATCH/PUT /turmas/1.json
  def update
    respond_to do |format|
      if @turma.update(turma_params)
        format.html { redirect_to @turma, notice: 'Turma was successfully updated.' }
        format.json { render :show, status: :ok, location: @turma }
      else
        format.html { render :edit }
        format.json { render json: @turma.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /turmas/1
  # DELETE /turmas/1.json
  def destroy
    @turma.destroy
    respond_to do |format|
      format.html { redirect_to turmas_url, notice: 'Turma was successfully destroyed.' }
      format.json { head :no_content }
    end
  end

  def buscar4
  @turmas = current_professor.turmas.where(["name like :nome ", {nome: "%#{params[:search]}%"}])
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_turma
      @turma = current_professor.turmas.find(params[:id])
    end

  def can_change
      unless professor_signed_in? && current_professor == @turma.professor_id
      redirect_to turma_path(params[:id])
    end
  end

    # Never trust parameters from the scary internet, only allow the white list through.
    def turma_params
      params.require(:turma).permit(:name, :numeroalunos, :professor_id, :professor_name, :curso_id, :curso_name, :search, :id)
    end
end
