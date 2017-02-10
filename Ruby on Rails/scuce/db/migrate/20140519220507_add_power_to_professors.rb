class AddPowerToProfessors < ActiveRecord::Migration
  def change
    add_column :professors, :power, :boolean, :default => false
  end
end
