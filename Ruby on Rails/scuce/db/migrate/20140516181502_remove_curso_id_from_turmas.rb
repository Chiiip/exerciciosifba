class RemoveCursoIdFromTurmas < ActiveRecord::Migration
  def change
    remove_column :turmas, :curso_id, :integer
  end
end
