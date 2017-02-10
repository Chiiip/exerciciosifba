class CreateAlunoTurmas < ActiveRecord::Migration
  def change
    create_table :aluno_turmas do |t|
      t.integer :numfaltas

      t.timestamps
    end
  end
end
