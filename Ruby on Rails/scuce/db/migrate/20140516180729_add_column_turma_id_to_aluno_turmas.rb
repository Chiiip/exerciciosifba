class AddColumnTurmaIdToAlunoTurmas < ActiveRecord::Migration
  def change
    add_column :aluno_turmas, :turma_id, :integer
  end
end
