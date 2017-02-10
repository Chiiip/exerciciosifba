class AddCursoIdToTurmas < ActiveRecord::Migration
  def change
    add_column :turmas, :curso_id, :integer
  end
end
