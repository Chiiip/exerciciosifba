class AddColumnAlunoIdToAlunoTurmas < ActiveRecord::Migration
  def change
    add_column :aluno_turmas, :aluno_id, :integer
  end
end
