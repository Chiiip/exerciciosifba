class AddColumnPowersToProfessors < ActiveRecord::Migration
  def change
    add_column :professors, :Powers, :boolean
  end
end
