class AddColumnNumeroalunosToTurmas < ActiveRecord::Migration
  def change
    add_column :turmas, :numeroalunos, :integer
  end
end
