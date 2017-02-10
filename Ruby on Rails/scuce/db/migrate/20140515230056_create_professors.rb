class CreateProfessors < ActiveRecord::Migration
  def change
    create_table :professors do |t|
      t.string :name
      t.string :phone
      t.string :email
      t.string :password

      t.timestamps
    end
  end
end
