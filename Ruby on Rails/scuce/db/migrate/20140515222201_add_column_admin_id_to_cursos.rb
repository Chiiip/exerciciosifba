class AddColumnAdminIdToCursos < ActiveRecord::Migration
  def change
    add_column :cursos, :admin_id, :integer
  end
end
