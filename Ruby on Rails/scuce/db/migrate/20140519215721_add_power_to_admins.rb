class AddPowerToAdmins < ActiveRecord::Migration
  def change
    add_column :admins, :power, :boolean, :default => true
  end
end
