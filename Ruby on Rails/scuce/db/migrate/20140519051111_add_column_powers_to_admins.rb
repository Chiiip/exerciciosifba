class AddColumnPowersToAdmins < ActiveRecord::Migration
  def change
    add_column :admins, :Powers, :boolean
  end
end
