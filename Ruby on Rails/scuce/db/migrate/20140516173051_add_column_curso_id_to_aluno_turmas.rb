class AddColumnCursoIdToAlunoTurmas < ActiveRecord::Migration
  def change
    add_column :aluno_turmas, :curso_id, :integer
  end
end
