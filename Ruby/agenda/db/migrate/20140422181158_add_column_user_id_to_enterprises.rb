class AddColumnUserIdToEnterprises < ActiveRecord::Migration
  def change
    add_column :enterprises, :user_id, :integer
  end
end
