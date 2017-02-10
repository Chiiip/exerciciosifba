require 'test_helper'

class AlunoTurmasControllerTest < ActionController::TestCase
  setup do
    @aluno_turma = aluno_turmas(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:aluno_turmas)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create aluno_turma" do
    assert_difference('AlunoTurma.count') do
      post :create, aluno_turma: { numfaltas: @aluno_turma.numfaltas }
    end

    assert_redirected_to aluno_turma_path(assigns(:aluno_turma))
  end

  test "should show aluno_turma" do
    get :show, id: @aluno_turma
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @aluno_turma
    assert_response :success
  end

  test "should update aluno_turma" do
    patch :update, id: @aluno_turma, aluno_turma: { numfaltas: @aluno_turma.numfaltas }
    assert_redirected_to aluno_turma_path(assigns(:aluno_turma))
  end

  test "should destroy aluno_turma" do
    assert_difference('AlunoTurma.count', -1) do
      delete :destroy, id: @aluno_turma
    end

    assert_redirected_to aluno_turmas_path
  end
end
