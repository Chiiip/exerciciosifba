class AddColumnNumeroalunosToCursos < ActiveRecord::Migration
  def change
    add_column :cursos, :numeroalunos, :integer
  end
end
